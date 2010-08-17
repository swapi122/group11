




/*
'===============================================================================
'  LayerHelper.CAQ.BL.NhomNguoiDungManagerBase
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
	public class NhomNguoiDungManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhomNguoiDungManagerBase()
		{
			// Nothing for now.
		}
		
		public NhomNguoiDungEntity Insert(NhomNguoiDungEntity _NhomNguoiDungEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NhomNguoiDungEntity, true);
			}
			return _NhomNguoiDungEntity;
		}

		
		public NhomNguoiDungEntity Insert(Guid Id, string TenNhomNguoiDung, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, string TrangThai)
		{
			NhomNguoiDungEntity _NhomNguoiDungEntity = new NhomNguoiDungEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NhomNguoiDungEntity.Id = Id;
				_NhomNguoiDungEntity.TenNhomNguoiDung = TenNhomNguoiDung;
				_NhomNguoiDungEntity.MaRutGon = MaRutGon;
				_NhomNguoiDungEntity.MaTp = MaTp;
				_NhomNguoiDungEntity.GhiChu = GhiChu;
				_NhomNguoiDungEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NhomNguoiDungEntity.IdNguoiTao = IdNguoiTao;
				_NhomNguoiDungEntity.NgayTao = NgayTao;
				_NhomNguoiDungEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NhomNguoiDungEntity.NgayCapNhat = NgayCapNhat;
				_NhomNguoiDungEntity.NgayHetHan = NgayHetHan;
				_NhomNguoiDungEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NhomNguoiDungEntity, true);
			}
			return _NhomNguoiDungEntity;
		}

		public NhomNguoiDungEntity Insert(string TenNhomNguoiDung, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, string TrangThai)
		{
			NhomNguoiDungEntity _NhomNguoiDungEntity = new NhomNguoiDungEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NhomNguoiDungEntity.TenNhomNguoiDung = TenNhomNguoiDung;
				_NhomNguoiDungEntity.MaRutGon = MaRutGon;
				_NhomNguoiDungEntity.MaTp = MaTp;
				_NhomNguoiDungEntity.GhiChu = GhiChu;
				_NhomNguoiDungEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NhomNguoiDungEntity.IdNguoiTao = IdNguoiTao;
				_NhomNguoiDungEntity.NgayTao = NgayTao;
				_NhomNguoiDungEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NhomNguoiDungEntity.NgayCapNhat = NgayCapNhat;
				_NhomNguoiDungEntity.NgayHetHan = NgayHetHan;
				_NhomNguoiDungEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NhomNguoiDungEntity, true);
			}
			return _NhomNguoiDungEntity;
		}

		public bool Update(NhomNguoiDungEntity _NhomNguoiDungEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NhomNguoiDungFields.Id == _NhomNguoiDungEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NhomNguoiDungEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NhomNguoiDungEntity _NhomNguoiDungEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NhomNguoiDungEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenNhomNguoiDung, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, string TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhomNguoiDungEntity _NhomNguoiDungEntity = new NhomNguoiDungEntity(Id);
				if (adapter.FetchEntity(_NhomNguoiDungEntity))
				{
				
					_NhomNguoiDungEntity.TenNhomNguoiDung = TenNhomNguoiDung;
					_NhomNguoiDungEntity.MaRutGon = MaRutGon;
					_NhomNguoiDungEntity.MaTp = MaTp;
					_NhomNguoiDungEntity.GhiChu = GhiChu;
					_NhomNguoiDungEntity.LoaiDanhMuc = LoaiDanhMuc;
					_NhomNguoiDungEntity.IdNguoiTao = IdNguoiTao;
					_NhomNguoiDungEntity.NgayTao = NgayTao;
					_NhomNguoiDungEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_NhomNguoiDungEntity.NgayCapNhat = NgayCapNhat;
					_NhomNguoiDungEntity.NgayHetHan = NgayHetHan;
					_NhomNguoiDungEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_NhomNguoiDungEntity, true);
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
				NhomNguoiDungEntity _NhomNguoiDungEntity = new NhomNguoiDungEntity(Id);
				if (adapter.FetchEntity(_NhomNguoiDungEntity))
				{
					adapter.DeleteEntity(_NhomNguoiDungEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenNhomNguoiDung(string TenNhomNguoiDung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TenNhomNguoiDung == TenNhomNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(string TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhomNguoiDungEntity", filter);
			}
			return toReturn;
		}
		

		
		public NhomNguoiDungEntity SelectOne(Guid Id)
		{
			NhomNguoiDungEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhomNguoiDungEntity _NhomNguoiDungEntity = new NhomNguoiDungEntity(Id);
				if (adapter.FetchEntity(_NhomNguoiDungEntity))
				{
					toReturn = _NhomNguoiDungEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectAllLST()
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, null, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByTenNhomNguoiDungLST(string TenNhomNguoiDung)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TenNhomNguoiDung == TenNhomNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByTenNhomNguoiDungLST_Paged(string TenNhomNguoiDung, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TenNhomNguoiDung == TenNhomNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenNhomNguoiDungRDT(string TenNhomNguoiDung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TenNhomNguoiDung == TenNhomNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenNhomNguoiDungRDT_Paged(string TenNhomNguoiDung, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TenNhomNguoiDung == TenNhomNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByTrangThaiLST(string TrangThai)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return EntityCollection<NhomNguoiDungEntity>
		public EntityCollection<NhomNguoiDungEntity> SelectByTrangThaiLST_Paged(string TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<NhomNguoiDungEntity> _NhomNguoiDungCollection = new EntityCollection<NhomNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhomNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NhomNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(string TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(string TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhomNguoiDungCollection = new EntityCollection(new NhomNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhomNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhomNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
