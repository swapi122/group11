




/*
'===============================================================================
'  LayerHelper.CAQ.BL.VaiTroTrongVuAnManagerBase
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
	public class VaiTroTrongVuAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VaiTroTrongVuAnManagerBase()
		{
			// Nothing for now.
		}
		
		public VaiTroTrongVuAnEntity Insert(VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VaiTroTrongVuAnEntity, true);
			}
			return _VaiTroTrongVuAnEntity;
		}

		
		public VaiTroTrongVuAnEntity Insert(Guid Id, string TenVaiTroTrongVuAn, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity = new VaiTroTrongVuAnEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VaiTroTrongVuAnEntity.Id = Id;
				_VaiTroTrongVuAnEntity.TenVaiTroTrongVuAn = TenVaiTroTrongVuAn;
				_VaiTroTrongVuAnEntity.MaRutGon = MaRutGon;
				_VaiTroTrongVuAnEntity.MaTp = MaTp;
				_VaiTroTrongVuAnEntity.GhiChu = GhiChu;
				_VaiTroTrongVuAnEntity.LoaiDanhMuc = LoaiDanhMuc;
				_VaiTroTrongVuAnEntity.IdNguoiTao = IdNguoiTao;
				_VaiTroTrongVuAnEntity.NgayTao = NgayTao;
				_VaiTroTrongVuAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VaiTroTrongVuAnEntity.NgayCapNhat = NgayCapNhat;
				_VaiTroTrongVuAnEntity.NgayHetHan = NgayHetHan;
				_VaiTroTrongVuAnEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VaiTroTrongVuAnEntity, true);
			}
			return _VaiTroTrongVuAnEntity;
		}

		public VaiTroTrongVuAnEntity Insert(string TenVaiTroTrongVuAn, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity = new VaiTroTrongVuAnEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VaiTroTrongVuAnEntity.TenVaiTroTrongVuAn = TenVaiTroTrongVuAn;
				_VaiTroTrongVuAnEntity.MaRutGon = MaRutGon;
				_VaiTroTrongVuAnEntity.MaTp = MaTp;
				_VaiTroTrongVuAnEntity.GhiChu = GhiChu;
				_VaiTroTrongVuAnEntity.LoaiDanhMuc = LoaiDanhMuc;
				_VaiTroTrongVuAnEntity.IdNguoiTao = IdNguoiTao;
				_VaiTroTrongVuAnEntity.NgayTao = NgayTao;
				_VaiTroTrongVuAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VaiTroTrongVuAnEntity.NgayCapNhat = NgayCapNhat;
				_VaiTroTrongVuAnEntity.NgayHetHan = NgayHetHan;
				_VaiTroTrongVuAnEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VaiTroTrongVuAnEntity, true);
			}
			return _VaiTroTrongVuAnEntity;
		}

		public bool Update(VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VaiTroTrongVuAnFields.Id == _VaiTroTrongVuAnEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VaiTroTrongVuAnEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VaiTroTrongVuAnEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenVaiTroTrongVuAn, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity = new VaiTroTrongVuAnEntity(Id);
				if (adapter.FetchEntity(_VaiTroTrongVuAnEntity))
				{
				
					_VaiTroTrongVuAnEntity.TenVaiTroTrongVuAn = TenVaiTroTrongVuAn;
					_VaiTroTrongVuAnEntity.MaRutGon = MaRutGon;
					_VaiTroTrongVuAnEntity.MaTp = MaTp;
					_VaiTroTrongVuAnEntity.GhiChu = GhiChu;
					_VaiTroTrongVuAnEntity.LoaiDanhMuc = LoaiDanhMuc;
					_VaiTroTrongVuAnEntity.IdNguoiTao = IdNguoiTao;
					_VaiTroTrongVuAnEntity.NgayTao = NgayTao;
					_VaiTroTrongVuAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_VaiTroTrongVuAnEntity.NgayCapNhat = NgayCapNhat;
					_VaiTroTrongVuAnEntity.NgayHetHan = NgayHetHan;
					_VaiTroTrongVuAnEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_VaiTroTrongVuAnEntity, true);
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
				VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity = new VaiTroTrongVuAnEntity(Id);
				if (adapter.FetchEntity(_VaiTroTrongVuAnEntity))
				{
					adapter.DeleteEntity(_VaiTroTrongVuAnEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenVaiTroTrongVuAn(string TenVaiTroTrongVuAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TenVaiTroTrongVuAn == TenVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VaiTroTrongVuAnEntity", filter);
			}
			return toReturn;
		}
		

		
		public VaiTroTrongVuAnEntity SelectOne(Guid Id)
		{
			VaiTroTrongVuAnEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VaiTroTrongVuAnEntity _VaiTroTrongVuAnEntity = new VaiTroTrongVuAnEntity(Id);
				if (adapter.FetchEntity(_VaiTroTrongVuAnEntity))
				{
					toReturn = _VaiTroTrongVuAnEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectAllLST()
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, null, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByTenVaiTroTrongVuAnLST(string TenVaiTroTrongVuAn)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TenVaiTroTrongVuAn == TenVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByTenVaiTroTrongVuAnLST_Paged(string TenVaiTroTrongVuAn, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TenVaiTroTrongVuAn == TenVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenVaiTroTrongVuAnRDT(string TenVaiTroTrongVuAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TenVaiTroTrongVuAn == TenVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenVaiTroTrongVuAnRDT_Paged(string TenVaiTroTrongVuAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TenVaiTroTrongVuAn == TenVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return EntityCollection<VaiTroTrongVuAnEntity>
		public EntityCollection<VaiTroTrongVuAnEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<VaiTroTrongVuAnEntity> _VaiTroTrongVuAnCollection = new EntityCollection<VaiTroTrongVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VaiTroTrongVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VaiTroTrongVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VaiTroTrongVuAnCollection = new EntityCollection(new VaiTroTrongVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VaiTroTrongVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VaiTroTrongVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
