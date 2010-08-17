




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhChatLienQuanManagerBase
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
	public class TinhChatLienQuanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhChatLienQuanManagerBase()
		{
			// Nothing for now.
		}
		
		public TinhChatLienQuanEntity Insert(TinhChatLienQuanEntity _TinhChatLienQuanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TinhChatLienQuanEntity, true);
			}
			return _TinhChatLienQuanEntity;
		}

		
		public TinhChatLienQuanEntity Insert(Guid Id, string TenTinhChatLienQuan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhChatLienQuanEntity _TinhChatLienQuanEntity = new TinhChatLienQuanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhChatLienQuanEntity.Id = Id;
				_TinhChatLienQuanEntity.TenTinhChatLienQuan = TenTinhChatLienQuan;
				_TinhChatLienQuanEntity.IdMaCha = IdMaCha;
				_TinhChatLienQuanEntity.MaRutGon = MaRutGon;
				_TinhChatLienQuanEntity.MaTp = MaTp;
				_TinhChatLienQuanEntity.GhiChu = GhiChu;
				_TinhChatLienQuanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhChatLienQuanEntity.IdNguoiTao = IdNguoiTao;
				_TinhChatLienQuanEntity.NgayTao = NgayTao;
				_TinhChatLienQuanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhChatLienQuanEntity.NgayCapNhat = NgayCapNhat;
				_TinhChatLienQuanEntity.NgayHetHan = NgayHetHan;
				_TinhChatLienQuanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhChatLienQuanEntity, true);
			}
			return _TinhChatLienQuanEntity;
		}

		public TinhChatLienQuanEntity Insert(string TenTinhChatLienQuan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhChatLienQuanEntity _TinhChatLienQuanEntity = new TinhChatLienQuanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhChatLienQuanEntity.TenTinhChatLienQuan = TenTinhChatLienQuan;
				_TinhChatLienQuanEntity.IdMaCha = IdMaCha;
				_TinhChatLienQuanEntity.MaRutGon = MaRutGon;
				_TinhChatLienQuanEntity.MaTp = MaTp;
				_TinhChatLienQuanEntity.GhiChu = GhiChu;
				_TinhChatLienQuanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhChatLienQuanEntity.IdNguoiTao = IdNguoiTao;
				_TinhChatLienQuanEntity.NgayTao = NgayTao;
				_TinhChatLienQuanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhChatLienQuanEntity.NgayCapNhat = NgayCapNhat;
				_TinhChatLienQuanEntity.NgayHetHan = NgayHetHan;
				_TinhChatLienQuanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhChatLienQuanEntity, true);
			}
			return _TinhChatLienQuanEntity;
		}

		public bool Update(TinhChatLienQuanEntity _TinhChatLienQuanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TinhChatLienQuanFields.Id == _TinhChatLienQuanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TinhChatLienQuanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TinhChatLienQuanEntity _TinhChatLienQuanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TinhChatLienQuanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenTinhChatLienQuan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhChatLienQuanEntity _TinhChatLienQuanEntity = new TinhChatLienQuanEntity(Id);
				if (adapter.FetchEntity(_TinhChatLienQuanEntity))
				{
				
					_TinhChatLienQuanEntity.TenTinhChatLienQuan = TenTinhChatLienQuan;
					_TinhChatLienQuanEntity.IdMaCha = IdMaCha;
					_TinhChatLienQuanEntity.MaRutGon = MaRutGon;
					_TinhChatLienQuanEntity.MaTp = MaTp;
					_TinhChatLienQuanEntity.GhiChu = GhiChu;
					_TinhChatLienQuanEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TinhChatLienQuanEntity.IdNguoiTao = IdNguoiTao;
					_TinhChatLienQuanEntity.NgayTao = NgayTao;
					_TinhChatLienQuanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TinhChatLienQuanEntity.NgayCapNhat = NgayCapNhat;
					_TinhChatLienQuanEntity.NgayHetHan = NgayHetHan;
					_TinhChatLienQuanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TinhChatLienQuanEntity, true);
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
				TinhChatLienQuanEntity _TinhChatLienQuanEntity = new TinhChatLienQuanEntity(Id);
				if (adapter.FetchEntity(_TinhChatLienQuanEntity))
				{
					adapter.DeleteEntity(_TinhChatLienQuanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTinhChatLienQuan(string TenTinhChatLienQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TenTinhChatLienQuan == TenTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdMaCha(Guid IdMaCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatLienQuanEntity", filter);
			}
			return toReturn;
		}
		

		
		public TinhChatLienQuanEntity SelectOne(Guid Id)
		{
			TinhChatLienQuanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhChatLienQuanEntity _TinhChatLienQuanEntity = new TinhChatLienQuanEntity(Id);
				if (adapter.FetchEntity(_TinhChatLienQuanEntity))
				{
					toReturn = _TinhChatLienQuanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectAllLST()
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, null, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByTenTinhChatLienQuanLST(string TenTinhChatLienQuan)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TenTinhChatLienQuan == TenTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByTenTinhChatLienQuanLST_Paged(string TenTinhChatLienQuan, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TenTinhChatLienQuan == TenTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhChatLienQuanRDT(string TenTinhChatLienQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TenTinhChatLienQuan == TenTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhChatLienQuanRDT_Paged(string TenTinhChatLienQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TenTinhChatLienQuan == TenTinhChatLienQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdMaChaLST(Guid IdMaCha)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdMaChaLST_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT(Guid IdMaCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return EntityCollection<TinhChatLienQuanEntity>
		public EntityCollection<TinhChatLienQuanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatLienQuanEntity> _TinhChatLienQuanCollection = new EntityCollection<TinhChatLienQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatLienQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatLienQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatLienQuanCollection = new EntityCollection(new TinhChatLienQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatLienQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatLienQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
