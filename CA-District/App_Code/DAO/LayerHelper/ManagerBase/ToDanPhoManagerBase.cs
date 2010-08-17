




/*
'===============================================================================
'  LayerHelper.CAQ.BL.ToDanPhoManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class ToDanPhoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ToDanPhoManagerBase()
		{
			// Nothing for now.
		}
		
		public ToDanPhoEntity Insert(ToDanPhoEntity _ToDanPhoEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ToDanPhoEntity, true);
			}
			return _ToDanPhoEntity;
		}

		
		public ToDanPhoEntity Insert(Guid Id, string TenToDanPho, Guid IdOkhuVuc, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			ToDanPhoEntity _ToDanPhoEntity = new ToDanPhoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ToDanPhoEntity.Id = Id;
				_ToDanPhoEntity.TenToDanPho = TenToDanPho;
				_ToDanPhoEntity.IdOkhuVuc = IdOkhuVuc;
				_ToDanPhoEntity.MaRutGon = MaRutGon;
				_ToDanPhoEntity.GhiChu = GhiChu;
				_ToDanPhoEntity.LoaiDanhMuc = LoaiDanhMuc;
				_ToDanPhoEntity.IdNguoiTao = IdNguoiTao;
				_ToDanPhoEntity.NgayTao = NgayTao;
				_ToDanPhoEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ToDanPhoEntity.NgayCapNhat = NgayCapNhat;
				_ToDanPhoEntity.NgayHetHan = NgayHetHan;
				_ToDanPhoEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ToDanPhoEntity, true);
			}
			return _ToDanPhoEntity;
		}

		public ToDanPhoEntity Insert(string TenToDanPho, Guid IdOkhuVuc, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			ToDanPhoEntity _ToDanPhoEntity = new ToDanPhoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ToDanPhoEntity.TenToDanPho = TenToDanPho;
				_ToDanPhoEntity.IdOkhuVuc = IdOkhuVuc;
				_ToDanPhoEntity.MaRutGon = MaRutGon;
				_ToDanPhoEntity.GhiChu = GhiChu;
				_ToDanPhoEntity.LoaiDanhMuc = LoaiDanhMuc;
				_ToDanPhoEntity.IdNguoiTao = IdNguoiTao;
				_ToDanPhoEntity.NgayTao = NgayTao;
				_ToDanPhoEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ToDanPhoEntity.NgayCapNhat = NgayCapNhat;
				_ToDanPhoEntity.NgayHetHan = NgayHetHan;
				_ToDanPhoEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ToDanPhoEntity, true);
			}
			return _ToDanPhoEntity;
		}

		public bool Update(ToDanPhoEntity _ToDanPhoEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ToDanPhoFields.Id == _ToDanPhoEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ToDanPhoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ToDanPhoEntity _ToDanPhoEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ToDanPhoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenToDanPho, Guid IdOkhuVuc, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ToDanPhoEntity _ToDanPhoEntity = new ToDanPhoEntity(Id);
				if (adapter.FetchEntity(_ToDanPhoEntity))
				{
				
					_ToDanPhoEntity.TenToDanPho = TenToDanPho;
					_ToDanPhoEntity.IdOkhuVuc = IdOkhuVuc;
					_ToDanPhoEntity.MaRutGon = MaRutGon;
					_ToDanPhoEntity.GhiChu = GhiChu;
					_ToDanPhoEntity.LoaiDanhMuc = LoaiDanhMuc;
					_ToDanPhoEntity.IdNguoiTao = IdNguoiTao;
					_ToDanPhoEntity.NgayTao = NgayTao;
					_ToDanPhoEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_ToDanPhoEntity.NgayCapNhat = NgayCapNhat;
					_ToDanPhoEntity.NgayHetHan = NgayHetHan;
					_ToDanPhoEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_ToDanPhoEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ToDanPhoEntity _ToDanPhoEntity = new ToDanPhoEntity(Id);
				if (adapter.FetchEntity(_ToDanPhoEntity))
				{
					adapter.DeleteEntity(_ToDanPhoEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ToDanPhoEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenToDanPho(string TenToDanPho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TenToDanPho == TenToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToDanPhoEntity", filter);
			}
			return toReturn;
		}
		

		
		public ToDanPhoEntity SelectOne(Guid Id)
		{
			ToDanPhoEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ToDanPhoEntity _ToDanPhoEntity = new ToDanPhoEntity(Id);
				if (adapter.FetchEntity(_ToDanPhoEntity))
				{
					toReturn = _ToDanPhoEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectAllLST()
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, null, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByTenToDanPhoLST(string TenToDanPho)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TenToDanPho == TenToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByTenToDanPhoLST_Paged(string TenToDanPho, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TenToDanPho == TenToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenToDanPhoRDT(string TenToDanPho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TenToDanPho == TenToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenToDanPhoRDT_Paged(string TenToDanPho, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TenToDanPho == TenToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdOkhuVucLST(Guid IdOkhuVuc)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdOkhuVucLST_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT(Guid IdOkhuVuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null);
			}
			return _ToDanPhoCollection;
		}
		
		// Return EntityCollection<ToDanPhoEntity>
		public EntityCollection<ToDanPhoEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<ToDanPhoEntity> _ToDanPhoCollection = new EntityCollection<ToDanPhoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToDanPhoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToDanPhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToDanPhoCollection = new EntityCollection(new ToDanPhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToDanPhoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToDanPhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
